import React, { useState, useEffect } from "react";
import { Route, Redirect, useHistory } from "react-router-dom";
import MovieDetails from "./MovieDetails";
const MovieRow = (props) => {
  const [movie, setMovie] = useState(props.movie);
  //const [active, setActive] = useState(false);
  const [hover, setHover] = useState(false);

  const history = useHistory();

  useEffect(() => {
    setMovie(props.movie);
  }, []);
  //useEffect(() => {
  //  redirectTo();
  //}, [active]);
    function redirectToDetails() {
    history.push({
        pathname: "/MovieDetails/",
       /// search:'?id={movie.id}',
      state: { movie: movie },
    });
  }
  const routeChange = () => {
    let path = `MovieDetails`;
    history.push(path);
  };
  return (
    <li
      onPointerOver={(e) => setHover(true)}
      onPointerOut={(e) => setHover(false)}
      onClick={(e) => {
          redirectToDetails();
        //setActive(!active);
      }}
      className={
        hover
          ? "table-row-highlighted"
          : /*           : active
          ? "table-row-selected" */
            "table-row"
      }
    >
      <div class="col col-1">{movie.title}</div>
      <div class="col col-2">{movie.source}</div>
      <div class="col col-3">$ {movie.price}</div>
    </li>
  );
};
export default MovieRow;
