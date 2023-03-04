class Person{
    constructor(fname,lname,year){
        this.fname = fname
        this.lname = lname
        this.year = year
    }
    getage(){
        return 2023 - this.year
    }
}
var person1 = new Person("tekle","mamphoria","2007")
var person2 = new Person("tekle","mamphoria","2000")
var person3 = new Person("tekle","mamphoria","2003")
var arr = [person1, person2,person3]
for(var i of arr){
    console.log(i.getage()) 
}