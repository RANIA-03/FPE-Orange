function Result() {
  let mark = parseInt(document.getElementById("mark").value); // Parse the input value as a number
  let grade = "";
  switch (true) {
    case mark < 50:
      grade = "FAIL";
      break;
    case mark >= 50 && mark <= 59:
      grade = "D";
      break;
    case mark >= 60 && mark <= 69:
      grade = "C";
      break;
    case mark >= 70 && mark <= 79:
      grade = "B";
      break;
    case mark >= 80 && mark <= 89:
      grade = "A";
      break;
    default:
      grade = "A+";
  }
  let text = document.querySelector(".myTxt");
  text.innerText = `Your mark is ${grade}`;
}
