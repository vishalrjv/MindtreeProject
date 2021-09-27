export interface UserForRegister {
     
     FirstName?:string ,
    
   Password:string ,
   
   EmailId:string  
}
export interface UserForLogin{
  EmailId:string,
  Password:string,
  token:string
}