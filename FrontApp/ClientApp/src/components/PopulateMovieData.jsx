import {useEffect, useState } from "react";
const PopulateMovieData=()=> {
    const [moviesList, setMoviesList] = useState([]);
    const [loading, setLoading] = useState("false");
    useEffect(() => {
        async function getMovieList() {
            try {
                const response = await fetch('Movies');
                const data = await response.json();
                setMoviesList({ forecasts: data });
                setLoading(false);
            }
            catch (error) { setLoading("null"); }
        }
    }, []);
    return [moviesList, loading];
}
export default PopulateMovieData;