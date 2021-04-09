import React, { useState } from "react";
import PopulateMovieData from "./PopulateMovieData";
import MovieRow from "./MovieRow";
import "./Movies.css";

const Movies = () => {
  const [List, loading] = PopulateMovieData();

  return (
    <div class="container">
      <h4>Movie List</h4>
      <ul class="table">
        <li class="table-header">
          <div class="col col-1">Name</div>
          <div class="col col-2">Source</div>
          <div class="col col-3">Price</div>
        </li>
        {loading === true ? (
          <p>Loading...</p>
        ) : loading === null ? (
          <p>No Movie Found</p>
        ) : (
          List.map((item) => item.map((movie) => <MovieRow movie={movie} />))
        )}
      </ul>
    </div>
  );
};
export default Movies;
