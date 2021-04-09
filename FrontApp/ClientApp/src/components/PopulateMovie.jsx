import { useState, useEffect } from "react";
import { getAccessToken } from "./PopulateMovieData";

const PopulateMovie = (props) => {
  const [movie, setMovie] = useState({});
  useEffect(() => {
    async function getMovieById() {
      const token = await getAccessToken();
      var bearer = "Bearer " + token;
      try {
        if (
          props !== undefined &&
          props.movieId !== "" &&
          props.source !== ""
        ) {
          var url =
            "Movies/byId?id=" + props.movieId + "&source=" + props.source;
          const response = await fetch(url, {
            headers: { Authorization: bearer },
          });
          const data = await response.json();

          setMovie(data);
        }
      } catch (error) {
        console.log(error);
      }
    }
    getMovieById();
  }, []);
  return movie;
};
export default PopulateMovie;
