function Result() {
  let num1 = parseFloat(prompt("Enter Number one : "));
  let num2 = parseFloat(prompt("Enter Number two : "));
  let text = document.querySelector(".myTxt");
  if (!isNaN(num1) && !isNaN(num2)) {
    if (num1 > num2) {
      alert("Hello World");
    } else {
      alert("Goodbye");
    }
  } else {
    alert("Invalid input.");
  }
}
