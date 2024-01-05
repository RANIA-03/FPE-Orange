function Result() {
  let radius = parseInt(document.getElementById("radius").value); 
  const pi = Math.PI
  let area =  pi * Math.pow(radius, 2);

  let text = document.querySelector(".myTxt");
  text.innerText = `Area of Circle is ${area}`;
}
