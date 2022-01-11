

const bar = document.getElementById('bar');
const close = document.getElementById('close');
const nav = document.getElementById('navbar');

if (bar) {
    bar.addEventListener('click', () => {
        nav.classList.add('active');
    })
}

if (close) {
    close.addEventListener('click', () => {
        nav.classList.remove('active');
    })
}

let time = 5000,
    currentImageIndex = 0,
    images = document
        .querySelectorAll("#hero img")
max = images.length;

function nextImage() {

    images[currentImageIndex]
        .classList.remove("ativo")

    currentImageIndex++

    if (currentImageIndex >= max)
        currentImageIndex = 0

    images[currentImageIndex]
        .classList.add("ativo")
}

function start() {
    setInterval(() => {
        // troca de image
        nextImage()
    }, time)
}

window.addEventListener("load", start)