//filter method is used to check any condition and create array baased on that condition    
const numbers=[2,3,4,5,6,7,8,9,10,12,45]
const evenNumbers=numbers.filter(num=>num%2==0)
console.log(evenNumbers);

const users=[
    {id:1,name:"Pedri",age:22},
    {id:2,name:"Casado",age:17},
    {id:3,name:"Gavi",age:17},
    {id:3,name:"Lewy",age:36},
];

const teenagers=users.filter((user)=>user.age>=13&&user.age<=19);
console.log(teenagers);

const products=[
    {id:1,name:"Laptop",details:{price:10099,instock:true}},
    {id:2,name:"Mobile",details:{price:1200,instock:false}},
    {id:3,name:"Shoes",details:{price:1999,instock:true}},
    {id:4,name:"Rice",details:{price:1100,instock:false}},
    {id:5,name:"Curtains",details:{price:800,instock:true}},
];
const productsInStock=products.filter(product=>product.details.instock);
console.log(productsInStock);