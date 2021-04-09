import { useState, useEffect } from "react";
const PopulateMovieData = () => {
  const [loading, setLoading] = useState("false");
  const [moviesList, setMoviesList] = useState([]);
  useEffect(() => {
    async function getMovieList() {
      const token = await getAccessToken();
      var bearer = "Bearer " + token;
      try {
        setLoading(true);
        const response = await fetch("Movies", {
          headers: { Authorization: bearer },
        });
        const data = await response.json();

        data.forEach(loopThroughInputList);
        setMoviesList(
          data.map((item) => {
            return item.movieList;
          })
        );
        setLoading(false);
      } catch (error) {
        setLoading(null);
      }
    }
    getMovieList();
  }, []);
  return [moviesList, loading];
};

export function getAccessToken() {
  return "sjd1HfkjU83ksdsm3802k";
}

function loopThroughInputList(item, index, arr) {
  for (let index = 0; index < item.movieList.length; ++index) {
    item.movieList[index].source = item.source;
  }
  console.log(arr);
}
export default PopulateMovieData;
