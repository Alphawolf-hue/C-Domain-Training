import React from "react";
function InlineStyleExample() {
    const style1={
        color: "blue",
        backgroundColour:"lightgray",
        padding: "10px",
        borderRadius: "5px",
    };
    return (
        <>
            <h1 style={style1}>This style is applied to inline</h1>
        </>
    );
}

export default InlineStyleExample;