
const targetDate = new Date('2023-08-17T12:00:00');

const day = document.getElementById('days');
const hr = document.getElementById('hour');
const min = document.getElementById('minute');
const sec = document.getElementById('seconds');

function updateTimer() 
{
    const now = new Date().getTime();
    const tr = targetDate - now;

    const days = Math.floor(tr / (1000 * 60 * 60 * 24));
    const hours = Math.floor((tr % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
    const minutes = Math.floor((tr % (1000 * 60 * 60)) / (1000 * 60));
    const seconds = Math.floor((tr % (1000 * 60)) / 1000);

    day.innerText = days;
    hr.innerText = hours;
    min.innerText = minutes;
    sec.innerHTML = seconds;
}

setInterval(updateTimer, 1000);
updateTimer()