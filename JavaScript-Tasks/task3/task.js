// console.log('Here is : ', 'array')

/*
1
Correct the syntax error
 [ 1,7  9  45, ]

 =>[ 1,7,  9,  45 ]

 ["Str" "alex","moh"

 => ["Str", "alex","moh"]

 'the','fox' 'over' lazy, 'dog',  ]
 
 =>['the','fox', 'over', lazy, 'dog']

*/

/*
2
What the index of "Banana","Tomato"
var fruits=["Tomato","Banana","Watermelon"]
"Banana"=>1   "Tomato"=>0
*/

/*
3
Create an array represents your:
1- Favorite Food (5)
2- Favorite Sport (3)
3- Favorite Movie (4)
*/
let favFood = ["Indomie", "Burger", "Mansaf", "Pizza", "Shawerma"];
let favSport = ["Swimming", "Gymnastics", "Ballet"];
let favMovie = ["Big Hero", "No Escape", "test", "test"];
/*
4
Create a function called firstOfArray
that take an array as a parameter
and return the first element in an array

Ex: firstOfArray([1,4,5]) => 1
Ex: firstOfArray(["t","u","g","x"]) => "t"
*/
function firstOfArray(arr) {
  return arr[0];
}
/*
5
Create a function called lastOfArray
that take an array as a parameter
and return the first element in an array

Ex: lastOfArray([1,4,5]) => 5
Ex: lastOfArray(["t","u","g","x"]) => "x"
*/
function firstOfArray(arr) {
  return arr[arr.length - 1];
}
/*
6
Using console make this array to be like this one (push, unshift, shift, pop)

var array = [0,5,7,9]
=> [1,3,4,6,8,9,10]
*/
var arr = [0, 5, 7, 9];
arr.unshift(1, 3, 4, 6, 8);
arr.shift();
arr.pop();
arr.push(10);
console.log(arr);
/*
7
Using the console try to figure out what the thing thats (push, unshift, shift, pop) return to you

var array2 = [5,9,-7,3.5]
*/
var arr2 = [5, 9, -7, 3.5];
console.log(arr2.push(2));
console.log(arr2.unshift(2));
console.log(arr2.shift(2));
console.log(arr2.pop());
console.log(arr2);
/*
8
Create a function called middleOfArray
that take an array as a parameter
and return the middle element in an array if it is have an odd elemnets
and return the two middle elemnt in an array if it is have an even elemnets

Ex: middleOfArray([1,4,5]) => 4
Ex: middleOfArray(["t","u","g","x"]) =>"u and g"
*/
function middleOfArray(arr) {
            if (arr.length % 2 == 1) {
                return ((arr[(arr.length - 1) / 2]));
            }
            return (arr[(arr.length - 2) / 2]) + " " + (arr[(arr.length) / 2]);
        }
/*
9
Using assignment operator (=)
make the animals array have these animals
var animals = ['cat', 'ele', 'bird']
animals; => ['zebra', 'elephant']
** hint: animals[0]=something
*/
let animals = ["zebra", "elephant"];
animals[0] = "cat";
animals[1] = "ele";
animals[2] = "bird";
/*
var nums= [1,2,3,8,9]
nums => [5,-22,3.5,44,98,44]
*/
var nums = [1, 2, 3, 8, 9];
nums.splice(3, 0, 5);
nums.splice(4, 0, -22);
nums.splice(5, 0, 3.5);
nums.splice(6, 0, 44);
nums.splice(7, 0, 98);
nums.splice(8, 0, 44);
/*
10
Create a function called indexOfArray
that accept an array and index
and return what this array have in this index

var nums= [1,2,3,8,9]
Ex: indexOfArray(nums,3) => 8
Ex: indexOfArray(nums,1) => 2
Ex: indexOfArray(nums,4) => 9

**try more cases by your self
*/
function indexOfArray(arr, num) {
  if (arr.length - 1 < num) return "Index out of bound";
  return arr[num];
}
/*
11
Create a function called arrayExceptLast
that accept an array
and return the entire array except the last elemnt
** hint: search abou the function that will cut the array on MDN
var nums= [1,2,3,8,9]
Ex: arrayExceptLast(nums) =>  [1,2,3,8]

**try more cases by your self
*/
function arrayExceptLast(arr) {
  return arr.slice(0, arr.length - 1);
}
/*
12
Create a function called addToEnd
that accept an array and value
and return the entire array with add this value to the end of this array

var nums= [1,2,3,8,9]
Ex: addToEnd(nums,55) =>  [1,2,3,8,55]

**try more cases by your self
*/
function addToEnd(arr, val) {
  arr.push(val);
}
// all the exercises below should solved 2 times: 1- for loop 2- while lopp
/*
13
Create a function called sumArray
that accept an array
and return the summation of all elemnt in this array

var nums= [1,2,3,8,9]
Ex: sumArray(nums) => 23

** solve it one time using for loop and another using while loop
**try more cases by your self
*/
function sumArray_ForLoop(arr) {
  let sum = 0;
  for (let i = 0; i < arr.length; i++) {
    sum += arr[i];
  }
  return sum;
}
function sumArray_WhileLoop(arr) {
  let sum = 0;
  let i = 0;
  while (i < arr.length) {
    sum += arr[i];
    i++;
  }
  return sum;
}
/*
14
Create a function called minInArray
that accept an array
and return the minimum value inside this array

var nums= [1,2,3,8,9]
Ex: minInArray(nums) => 1

** solve it one time using for loop and another using while loop
**try more cases by your self
*/
function minInArray_ForLoop(arr) {
  let min = arr[0];
  for (let i = 0; i < arr.length; i++) {
    if (min > arr[i]) {
      min = arr[i];
    }
  }
  return min;
}
function minInArray_WhileLoop(arr) {
  let min = arr[0];
  let i = 0;
  while (i < arr.length) {
    if (min > arr[i]) {
      min = arr[i];
    }
    i++;
  }
  return min;
}
/*
15
Create a function called removeFromArray
that accept an array and elemnt to remove
and return the array after remove this elemnt from it

var nums= [1,2,3,8,9]
Ex: minInArray(nums,8) => [1,2,3,9]

** solve it one time using for loop and another using while loop
**try more cases by your self
*/
function removeFromArray_ForLoop(arr, num) {
  let myArr = [];
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] != num) {
      myArr.push(arr[i]);
    }
  }
  return myArr;
}
function removeFromArray_WhileLoop(arr, num) {
  let myArr = [];
  let i = 0;
  while (i < arr.length) {
    if (arr[i] != num) {
      myArr.push(arr[i]);
    }
    i++;
  }
  return myArr;
}
/*
16
Create a function called oddArray
that accept an array
and return an array have only the odd elemnts

var nums= [1,2,3,8,9]
Ex: oddArray(nums) => [1,3,9]

** solve it one time using for loop and another using while loop
**try more cases by your self
*/
function oddArray_ForLoop(arr) {
  let myArr = [];
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] % 2 == 1) {
      myArr.push(arr[i]);
    }
  }
  return myArr;
}
function oddArray_WhileLoop(arr) {
  let myArr = [];
  let i = 0;
  while (i < arr.length) {
    if (arr[i] % 2 == 1) {
      myArr.push(arr[i]);
    }
    i++;
  }
  return myArr;
}
/*
17
Create a function called aveArray
that accept an array
and return the average of the numbers inside this array

var nums= [1,2,3,8,9]
Ex: aveArray(nums) => 4.6

var nums2= [1,2,3,8,9,77]
Ex: aveArray(nums) => 16.6

** solve it one time using for loop and another using while loop
**try more cases by your self
*/
function aveArray_ForLoop(arr) {
  let sum = 0;
  for (let i = 0; i < arr.length; i++) {
    sum += arr[i];
  }
  return sum / arr.length;
}
function aveArray_WhileLoop(arr) {
  let sum = 0;
  let i = 0;
  while (i < arr.length) {
    sum += arr[i];

    i++;
  }
  return sum / arr.length;
}
/*
18
Create a function called shorterInArray
that accept an array of strings
and return the shortest string inside this array (first)

var strings= ["alex","mercer","madrasa","rashed2","emad","hala"]
Ex: shorterInArray(strings) => "alex"

** solve it one time using for loop and another using while loop
**try more cases by your self
*/
function shorterInArray_ForLoop(arr) {
  let shortest = arr[0];
  for (let i = 0; i < arr.length; i++) {
    if (arr[i].length < arr.length) {
      shortest = arr[i];
    }
  }
  return shortest;
}
function shorterInArray_WhileLoop(arr) {
  let shortest = arr[0];
  let i = 0;
  while (i < arr.length) {
    if (arr[i].length < arr.length) {
      shortest = arr[i];
    }
    i++;
  }
  return shortest;
}
/*
19
Create a function called repeatChar
that accept a string and char
and return the times that this char repeat inside this string

var string= "alex mercer madrasa rashed2 emad hala"
Ex: repeatChar(string,"a") => 6
Ex: repeatChar(string,"z") => 0

** solve it one time using for loop and another using while loop
**try more cases by your self
*/
function repeatChar_ForLoop(arr, ch) {
  let count = 0;
  for (let i = 0; i < arr.length; i++) {
    if (arr[i] == ch) {
      count++;
    }
  }
  return count;
}
function repeatChar_WhileLoop(arr, ch) {
  let count = 0;
  let i = 0;
  while (i < arr.length) {
    if (arr[i] == ch) {
      count++;
    }
    i++;
  }
  return count;
}
/*
20
Create a function called evenIndexOddLength
that accept an array of strings
and return a new array that have the string with odd length in even index

var strings= ["alex","mercer","madrasa","rashed2","emad","hala"]
Ex: evenIndexOddLength(strings) => ["madrasa"]

** solve it one time using for loop and another using while loop
**try more cases by your self
*/
function evenIndexOddLength_ForLoop(arr) {
  let myArr = [];
  for (let i = 0; i < arr.length; i += 2) {
    if (arr[i].length % 2 == 1) {
      myArr.push(arr[i]);
    }
  }
  return myArr;
}
function evenIndexOddLength_WhileLoop(arr) {
  let myArr = [];
  let i = 0;
  while (i < arr.length) {
    if (arr[i].length % 2 == 1) {
      myArr.push(arr[i]);
    }
    i += 2;
  }
  return myArr;
}
/*
21
Create a function called powerElementIndex
that accept an array of number
and return a new array that have the elemnt power by the index of it self

var nums= [44, 5, 4, 3, 2, 10]
Ex: powerElementIndex(nums) => [0, 5, 16, 27, 16, 100000]

** solve it one time using for loop and another using while loop
**try more cases by your self
*/
function powerElementIndex_ForLoop(arr) {
  for (let i = 0; i < arr.length; i++) {
    arr[i] = Math.pow(arr[i], i);
  }
  return arr;
}
function powerElementIndex_WhileLoop(arr) {
  let i = 0;
  while (i < arr.length) {
    arr[i] = Math.pow(arr[i], i);
    i++;
  }
  return arr;
}
/*
22
Create a function called evenNumberEvenIndex
that accept an array of nums
and return a new array that have the even number in even index

var nums= [5,2,2,1,8,66,55,77,34,9,55,1]
Ex: evenNumberEvenIndex(nums) => [2,8,34]

** solve it one time using for loop and another using while loop
**try more cases by your self
*/
function evenNumberEvenIndex_ForLoop(arr) {
  let myArr = [];
  for (let i = 0; i < arr.length; i += 2) {
    if (arr[i] % 2 == 0) {
      myArr.push(arr[i]);
    }
  }
  return myArr;
}
function evenNumberEvenIndex_WhileLoop(arr) {
  let myArr = [];
  let i = 0;
  while (i < arr.length) {
    if (arr[i] % 2 == 0) {
      myArr.push(arr[i]);
    }
    i += 2;
  }
  return myArr;
}
