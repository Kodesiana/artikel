package main

import (
	"flag"
	"fmt"
	"io"
	"log"
	"net"
)

func ByteCountSI(b int64) string {
	const unit = 1000
	if b < unit {
		return fmt.Sprintf("%d B", b)
	}

	div, exp := int64(unit), 0
	for n := b / unit; n >= unit; n /= unit {
		div *= unit
		exp++
	}

	return fmt.Sprintf("%.1f %cB", float64(b)/float64(div), "kMGTPE"[exp])
}

func main() {
	localHost := flag.String("lh", "0.0.0.0", "Local host to forward")
	localPort := flag.Int("lp", -1, "Enter local port to forward")
	remoteHost := flag.String("rh", "localhost", "Remote host to listen to")
	remotePort := flag.Int("rp", -1, "Enter remote port to listen to")

	flag.Parse()

	if *remotePort == -1 || *localPort == -1 {
		log.Fatal("Local or remote port is not set")
	}

	localAddress := fmt.Sprintf("%s:%d", *localHost, *localPort)
	remoteAddress := fmt.Sprintf("%s:%d", *remoteHost, *remotePort)

	ln, err := net.Listen("tcp", localAddress)
	if err != nil {
		log.Fatal(err)
	}

	log.Printf("Port forwarding %s --> %s", remoteAddress, localAddress)

	for {
		conn, err := ln.Accept()
		if err != nil {
			log.Fatal(err)
		}

		go handleConnection(conn, remoteAddress)
	}
}

func forward(src, dest net.Conn) {
	defer src.Close()
	defer dest.Close()

	written, err := io.Copy(src, dest)
	log.Printf("Handling traffic, written bytes: %s (%d)", ByteCountSI(written), written)
	if err != nil {
		log.Println("Connection is closed")
	}
}

func handleConnection(c net.Conn, remoteAddress string) {
	log.Println("Connection from:", c.RemoteAddr())

	remote, err := net.Dial("tcp", remoteAddress)
	if err != nil {
		log.Fatal(err)
	}

	log.Println("Connected to", remoteAddress)

	go forward(c, remote)
	go forward(remote, c)
}
