export class User{
    fname:string = ""
    lname:string = ""
    email:string = ""
    password:string = ""
    id:string = ""
    toObject(): any {
        return {
            fname: this.fname,
            lname: this.lname,
            email: this.email + "@gmail.com",
            password: this.password,
            id: this.id
        };
    }
}