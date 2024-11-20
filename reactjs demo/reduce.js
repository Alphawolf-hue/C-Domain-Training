const numbers=[1,2,3,4,5];
const sum=numbers.reduce((accumulator,currentValue)=>accumulator+currentValue,0);

console.log(sum);

const nestedArrays=[[1,2,3],[4,5,6],[7,8,9]];
const flattenedArray=nestedArrays.reduce((accumulator,currentValue)=>accumulator.concat(currentValue),[]);

console.log(flattenedArray);

const users=[
    {id:1,name:"Pedri",city:"Barcelona"},
    {id:2,name:"Casado",city:"Barcelona"},
    {id:3,name:"Ninja Turle",city:"Madrid"},
    {id:4,name:"Vini Jr",city:"Madrid"},
    {id:5,name:"Haaland",city:"Manchester"},
]

const groupbyCity=users.reduce((accumulator,currentValue)=>{
    const key=currentValue.city;
    if(!accumulator[key]){
        accumulator[key]=[];
        }
        accumulator[key].push(currentValue);
        return accumulator;
    },{});
    console.log(groupbyCity);

    const cart=[
        {product:"Laptop",price:10099,quantity:1},
        {product:"Pen",price:90,quantity:5},
        {product:"Mouse",price:60,quantity:10},
    ];

    const totalPrice=cart.reduce((accumulator,item)=>{
        return accumulator+item.price*item.quantity;
    },0);

    console.log(totalPrice);
   