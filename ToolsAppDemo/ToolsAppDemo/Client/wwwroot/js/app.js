

window.toolsAppDemo = {};

window.toolsAppDemo.doIt = function () {
  console.log("did it");
};

window.toolsAppDemo.ucase = function (someString) {
  return String(someString).toUpperCase();
};


//if (window.confirm("Are you sure you want to do this?")) {
//  console.log("yes, i do");
//} else {
//  console.log("no, i don't");
//}