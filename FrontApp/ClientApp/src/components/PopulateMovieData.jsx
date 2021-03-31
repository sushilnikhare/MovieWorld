import {useEffect, useState } from "react";
const PopulateMovieData=()=> {
    const [moviesList, setMoviesList] = useState([]);
    const [loading, setLoading] = useState("false");
    const [source, setSource] = useState("unknown");
    useEffect(() => {
        async function getMovieList() {
            const token = await getAccessToken();
            var bearer = 'Bearer ' + token;
            try {
                setLoading(true);
                const response = await fetch('Movies', { headers: { 'Authorization': bearer } });
                const data = await response.json();
                setMoviesList(
                    data.map(item => {
                        setSource(item.source);
                        //return item.movieList;
                        item.movieList.map(movie => {
                            return movie;
                        })
                    })
                );
                setLoading(false);
            }
            catch (error) { setLoading(null); }
        }
        getMovieList();
    }, []);
    return [moviesList,source, loading];
}
 function getAccessToken() {
    return 'sjd1HfkjU83ksdsm3802k';
}
export default PopulateMovieData;