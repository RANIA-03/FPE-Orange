function Result() {
  let op = document.getElementById("operation").value;
  let num1 = parseFloat(document.getElementById("number1").value);
  let num2 = parseFloat(document.getElementById("number2").value);
  let result = 0;
  switch (op) {
    case "+":
      result = num1 + num2;
      break;
    case "-":
      result = num1 - num2;
      break;
    case "*":
      result = num1 * num2;
      break;
    case "/":
      result = num1 / num2;
      break;
    default:
      result = NaN;
  }
  let text = document.querySelector(".myTxt");
  if (!isNaN(result)) {
    text.innerText = `${num1} ${op} ${num2} = ${result}`;
  } else {
    text.innerText = "Invalid Operation";
  }
}
