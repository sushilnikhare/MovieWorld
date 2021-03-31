import React from "react";
import PopulateMovieData from "./PopulateMovieData"
const Movies = () => {
    const [moviesList, source ,loading] = PopulateMovieData();

    return (
        <div>
            <h6 id="tabelLabel" >Movie List from {source}</h6>
            {loading === "true" ? (
                <h1>Loading...</h1>
            ) : loading === "null" ? (
                <h1>No Movie Found</h1>
            ) : (
                        moviesList.map(item => {
                            return (<li> {item.title}, ${item.price} </li>);
                        })
                    )}
        </div>
    );
}
export default Movies;