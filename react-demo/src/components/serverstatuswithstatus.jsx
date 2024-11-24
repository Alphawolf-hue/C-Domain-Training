import React,{useState} from "react";


const servers=[
    {id:1,name:"Azure SQl",location:"New York",isOnline:true},
    {id:2,name:"AWS SQl",location:"Tokyo",isOnline:false},
    {id:3,name:"Google SQl",location:"London",isOnline:false},
    {id:4,name:"Azure Paas",location:"kolkata",isOnline:true},
];

export default function ServerStatus(){
    return(
        <>
        <div className="server-list">
            {servers.map((server)=>(
               <div
               key={server.id}
               className="server-item"
               style={{color:server.isOnline?"green":"red"}}
               >
                <h3>{server.name}</h3>
                <p>Location:{server.location}</p>
                <p>Status:{server.isOnline?"Online":"Offline"}</p>
               </div>
            ))}
        </div>
        </>
    );
}