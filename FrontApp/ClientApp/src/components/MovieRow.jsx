import React, { useState, useEffect } from "react";
import { Route, Redirect, useHistory } from "react-router-dom";
import MovieDetails from "./MovieDetails";
const MovieRow = (props) => {
  const [movie, setMovie] = useState(props.movie);
  const [source, setSource] = useState(props.source);
  const [active, setActive] = useState(false);
  const [hover, setHover] = useState(false);

  const history = useHistory();

  useEffect(() => {
    setMovie(props.movie);
    setSource(props.source);
  }, []);
  //useEffect(() => {
  //  redirectTo();
  //}, [active]);
  function redirectTo() {
      console.log(source);
      history.push({ pathname: "/MovieDetails", state: { movie: movie, source: source } });
    //  return (
    //      <Redirect to={} component= {MovieDetails} />
    //);
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
        redirectTo();
        setActive(!active);
      }}
      className={
        hover
          ? "table-row-highlighted"
          : active
          ? "table-row-selected"
          : "table-row"
      }
    >
      <div class="col col-1">{movie.title}</div>
      <div class="col col-2">{source}</div>
      <div class="col col-3">$ {movie.price}</div>
    </li>
  );
};
export default MovieRow;
