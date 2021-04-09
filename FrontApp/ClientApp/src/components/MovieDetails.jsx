import React, { useState, useEffect } from "react";
import { useLocation } from "react-router-dom";
import PopulateMovie from "./PopulateMovie";
const MovieDetails = () => {
  const location = useLocation();
  var movie = PopulateMovie(location.state.movie);

  return (
    <div class="container">
      <h4>Movie Details</h4>
      {movie !== undefined && (
        <ul class="table">
          <li class="table-row">
            <div class="col col-1">Id</div>
            <div class="col col-1">{movie.movieId}</div>
          </li>
          <li class="table-row">
            <div class="col col-1">Name</div>
            <div class="col col-1">{movie.title}</div>
          </li>
          <li class="table-row">
            <div class="col col-1">Price</div>
            <div class="col col-1">$ {movie.price}</div>
          </li>
        </ul>
      )}
    </div>
  );
};
export default MovieDetails;
