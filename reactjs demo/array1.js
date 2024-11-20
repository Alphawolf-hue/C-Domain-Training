/*const data=["Leo",900,"Ronaldo",450]
data.forEach((datam)=>{
    console.log(datam);
});
*/
const users=[
    {id:1,name:"Pedri",email:"xyz1"},
    {id:2,name:"Casado",email:"xyz2"},
    {id:3,name:"Gavi",email:"xyz3"},
];

users.forEach((user)=>{
    console.log(`ID:${user.id} Name:${user.name} Email:${user.email}`);
});

const numbers=[5,65,80,90];
const doublednumbers=numbers.map((number)=>number*2);
console.log(doublednumbers);
