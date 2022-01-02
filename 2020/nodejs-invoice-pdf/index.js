const fs = require('fs');
const puppeteer = require('puppeteer');
const mustache = require('mustache');

(async () => {
    const browser = await puppeteer.launch({ args: [
        '--no-sandbox',
        '--disable-setuid-sandbox',
        '--disable-dev-shm-usage'
        ]
    });
    const page = await browser.newPage();

    const htmlBody = fs.readFileSync('./halaman.html', 'utf-8');
    const data = {
        nomor: 112,
        tanggal: "21 September 2020",
        alamat: "Bogor, Jawa Barat",
        pembayaran: [
            { metode: "Tunai", jumlah: "Rp2.000.000" }
        ],
        barang: [
            { item: "nVidia GeForce 3090 RTX", harga: "Rp1.000.000" },
            { item: "AMD Ryzen 7", harga: "Rp1.000.000" }
        ],
        total: "Rp2.000.000"
    };

    await page.setContent(mustache.render(htmlBody, data));
    const pdf = await page.pdf({ format: 'A4' });
    fs.writeFileSync("./invoice.pdf", pdf);

    page.close();
    browser.close();
})();