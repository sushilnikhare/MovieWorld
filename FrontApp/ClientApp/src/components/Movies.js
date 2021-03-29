import React, {  useEffect, useState } from 'react';
import PopulateMovieData from "./PopulateMovieData"
const Movies = () => {
    const [moviesList, loading] = PopulateMovieData();

    return (
        <div>
            <h1 id="tabelLabel" >Movie List</h1>
            {loading === "false" ? (
                <h1>No Movie Found</h1>
            ) : loading === "null" ? (
                <h1>No Movie Found</h1>
            ) : (
                        moviesList.map(item => {
                            return <p>Book Title : {item.Title}</p>;
                        })
                    )}
        </div>
    );
}

export default Movies;
//export class FetchData extends Component {
//  static displayName = FetchData.name;

//  constructor(props) {
//    super(props);
//    this.state = { Movies: [], loading: true };
//  }

//  componentDidMount() {
//    this.populateWeatherData();
//  }

//  static renderForecastsTable(forecasts) {
//    return (
//      <table className='table table-striped' aria-labelledby="tabelLabel">
//        <thead>
//          <tr>
//            <th>Date</th>
//            <th>Temp. (C)</th>
//            <th>Temp. (F)</th>
//            <th>Summary</th>
//          </tr>
//        </thead>
//        <tbody>
//          {forecasts.map(forecast =>
//            <tr key={forecast.date}>
//              <td>{forecast.date}</td>
//              <td>{forecast.temperatureC}</td>
//              <td>{forecast.temperatureF}</td>
//              <td>{forecast.summary}</td>
//            </tr>
//          )}
//        </tbody>
//      </table>
//    );
//  }

//  render() {
//    let contents = this.state.loading
//      ? <p><em>Loading...</em></p>
//      : FetchData.renderForecastsTable(this.state.forecasts);

 
//  }


//}
