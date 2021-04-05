import React, { useState ,useEffect} from "react";
import { useLocation } from "react-router-dom";
const MovieDetails = (props) => {
    const [movie, setMovie] = useState(props.movie);
    const [source, setSource] = useState(props.source);
    const location = useLocation();
    useEffect(() => {
        console.log(location.pathname); 
        setMovie(location.state.movie);
        setSource(location.state.source);
    }, [location]);
  return (
    <div class="container">
          <h4>Movie Details</h4>
          {movie !== undefined &&
              <ul class="table">
                  <li class="table-row">
                      <div class="col col-1">Name</div>
                      <div class="col col-1">{movie.title}</div>
                  </li>

                  <li class="table-row">
                      <div class="col col-1">Source</div>
                      <div class="col col-1">{source}</div>
                  </li>

                  <li class="table-row">
                      <div class="col col-1">Price</div>
                      <div class="col col-1">$ {movie.price}</div>
                  </li>
              </ul>}
    </div>
  );
};
export default MovieDetails;
