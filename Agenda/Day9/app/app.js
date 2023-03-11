// async function sendRequest() {
//   var time = new Date().toISOString();
//   var response = await fetch("https://localhost:7174/api/Mobiles/date", {
//     method: "post",
//     headers: { "content-type": "application/json" },
//     body: JSON.stringify({ time }),
//   });
//   var result = await response.json();
//   console.log(result);
// }

// sendRequest();

var body = {
  time: userInput,
  name: "Bassant",
};

for (const key in body) {
  if (body[key] instanceof Date){
    adjustDate(body[key])
  }
}

function adjustDate(date) {
  const offset = 180 + date.getTimezoneOffset();
  date.setMinutes(date.getMinutes() - offset);
}
