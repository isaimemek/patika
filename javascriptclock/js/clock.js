let person = prompt("Adınız: ");

// Give warning and prompt again as long as "ok" button is used.
while (person == "") {
  alert("isim giriniz");
  person = prompt("Adınız: ");
}

// Use "isimsiz" word as placeholder if prompt windows is canceled.
if (person == null) {
  person = "isimsiz";
}

myName.innerHTML = person;

showTime(); // Time show up a bit after page load without this.

function showTime() {
  const weekday = [
    "Pazar",
    "Pazartesi",
    "Salı",
    "Çarşamba",
    "Perşembe",
    "Cuma",
    "Cumartesi",
  ];

  const currentTime = new Date();
  currentTime.toLocaleTimeString();
  document.getElementById("myClock");
  myClock.innerHTML = `
    ${currentTime.getHours()} :
    ${currentTime.getMinutes()} :
    ${currentTime.getSeconds()} 
    ${weekday[currentTime.getDay()]}
    `;
}

setInterval(function () {
  showTime();
}, 1000);
