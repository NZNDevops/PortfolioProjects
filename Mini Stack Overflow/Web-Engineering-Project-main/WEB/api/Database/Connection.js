var mysql = require('mysql');

var con = mysql.createConnection({
  host: "localhost",
  user: "root",
  password: "",
  database: "sibaoverflow"
});

con.connect(function(err) {
 
  console.log("Connected!");
});


module.exports = con;