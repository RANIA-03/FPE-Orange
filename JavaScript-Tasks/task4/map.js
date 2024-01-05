/*
Instructions: 
 - You should solve all these questions using .map() function 
*/

/*
 * Exercise 1:
 *
 * Make an array of numbers that are doubles of the first array
 *
 * Test Case:
 *
 * console.log(doubleNumbers([2, 5, 100]));
 *
 * Result:
 * [4, 10, 200]
 */

function doubleNumbers(arr) {
  return arr.map((i) => {
    return i * 2;
  });
}

/*
 * Exercise 2 :
 *
 * Take an array of numbers and make them strings
 *
 * Test Case:
 *
 * console.log(stringItUp([2, 5, 100]));
 *
 * Result:
 * ["2", "5", "100"]
 */

function stringItUp(arr) {
  return arr.map((i) => {
    return i.toString();
  });
}

/*
 * Exercise 3:
 *
 * Capitalize each of an array of names
 *
 * Test Case:
 *
 * console.log(capitalizeNames(["john", "JACOB", "jinGleHeimer", "schmidt"]));
 *
 * Result:
 *  ["John", "Jacob", "Jingleheimer", "Schmidt"]
 */

function capitalizeNames(arr) {
  return arr.map((i) => {
    return i[0].toUpperCase() + i.slice(1).toLowerCase();
  });
}

/*
 * Exercise 4:
 *
 * Make an array of strings of the names
 *
 * Test Case:
 *
 * console.log(namesOnly([
 *   {
 *       name: "Angelina Jolie",
 *       age: 80
 *   },
 *   {
 *       name: "Eric Jones",
 *       age: 2
 *   },
 *   {
 *       name: "Paris Hilton",
 *       age: 5
 *   },
 *   {
 *       name: "Kayne West",
 *       age: 16
 *   },
 *   {
 *       name: "Bob Ziroll",
 *       age: 100
 *   }
 *   ]));
 *
 * Result:
 *  ["Angelina Jolie", "Eric Jones", "Paris Hilton", "Kayne West", "Bob Ziroll"]
 */

function namesOnly(arr) {
  return arr.map((i) => {
    return i.name;
  });
}
/*
 * Exercise 5:
 *
 * Make an array of strings of the names saying whether or not they can go to The Matrix
 *
 * Test Case:
 *
 * console.log(makeStrings([
 *    {
 *       name: "Angelina Jolie",
 *       age: 80
 *   },
 *   {
 *       name: "Eric Jones",
 *       age: 2
 *   },
 *   {
 *       name: "Paris Hilton",
 *       age: 5
 *   },
 *   {
 *       name: "Kayne West",
 *       age: 16
 *   },
 *   {
 *       name: "Bob Ziroll",
 *       age: 100
 *   }
 * ]));
 *
 * Result:
 *
 * ["Angelina Jolie can go to The Matrix",
 * "Eric Jones is under age!!",
 * "Paris Hilton is under age!!",
 * "Kayne West is under age!!",
 * "Bob Ziroll can go to The Matrix"]
 *  ["John", "Jacob", "Jingleheimer", "Schmidt"]
 */

function makeStrings(arr) {
  return arr.map((i) => {
    if (i.age > 17) return i.name + " can go to The Matrix";
    return i.name + " is under age!!";
  });
}

/*
 * Exercise 6:
 *
 * Make an array of the names in h1s, and the ages in h2s
 *
 * Test Case:
 *
 * console.log(readyToPutInTheDOM([
 *   {
 *       name: "Angelina Jolie",
 *       age: 80
 *   },
 *   {
 *       name: "Eric Jones",
 *       age: 2
 *   },
 *   {
 *       name: "Paris Hilton",
 *       age: 5
 *   },
 *   {
 *       name: "Kayne West",
 *       age: 16
 *   },
 *   {
 *       name: "Bob Ziroll",
 *       age: 100
 *   }
 * ]));
 *
 * Result:
 *
 * ["<h1>Angelina Jolie</h1><h2>80</h2>",
 * "<h1>Eric Jones</h1><h2>2</h2>",
 * "<h1>Paris Hilton</h1><h2>5</h2>",
 * "<h1>Kayne West</h1><h2>16</h2>",
 * "<h1>Bob Ziroll</h1><h2>100</h2>"]
 */

function readyToPutInTheDOM(arr) {
  return arr.map((i) => {
    return `<h1>${i.name}</h1><h2>${i.age}</h2>`;
  });
}

/*
 * Exercise 7:
 * Write a function called doubleValues which accepts an array and returns a new array with all the values in the array passed to the function doubled
 *
 * Test Cases:
 *   Test Case 1:  doubleValues([1,2,3])
 *   Test Case 2:  doubleValues([1,-2,-3])
 *
 * Result:
 * Test Case 1: [2,4,6]
 * Test Case 2: [2,-4,-6]
 */

function doubleValues(arr) {
  return arr.map((i) => {
    if (i < 0) return i * 2 * -1;
    return i * 2;
  });
}

/*
 * Exercise 8:
 * Write a function called valTimesIndex which accepts an array and returns a new array with each value multiplied by the index it is currently at in the array.
 *
 *
 * Test Cases :
 *   Test Case 1:  valTimesIndex([1,2,3])
 *   Test Case 2:  valTimesIndex([1,-2,-3])
 *
 * Result
 * Test Case 1: [0,2,6]
 * Test Case 2: [0,-2,-6]
 */

function valTimesIndex(arr) {
  return arr.map((i, indx) => {
    return i * indx;
  });
}

/*
 * Exercise 9:
 * Write a function called extractKey which accepts an array of objects and some key and returns a new array with the value
 * of that key in each object.
 *
 * Test Case:
 * extractKey([{name: 'Elie'}, {name: 'Tim'}, {name: 'Matt'}, {name: 'Colt'}], 'name')
 *
 * Result:
 * ['Elie', 'Tim', 'Matt', 'Colt']
 */

function extractKey(arr, key) {
  return arr.map((i) => {
    return i[key];
  });
}

/*
 * Exercise 10:
 * Write a function called extractFullName which accepts an array of objects and returns a new array with the value of the key with a name of "first" and the value of a key with the name of  "last" in each object, concatenated together with a space.
 *
 * Examples:
 * extractFullName([{first: 'Elie', last:"Schoppik"}, {first: 'Tim', last:"Garcia"}, {first: 'Matt', last:"Lane"}, {first: 'Colt', last:"Steele"}]) // ['Elie Schoppik', 'Tim Garcia', 'Matt Lane', 'Colt Steele']
 */

function extractFullName(arr) {
  return arr.map((i) => {
    return i.first + " " + i.last;
  });
}
