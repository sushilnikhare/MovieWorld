import React from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import Home from './components/Home';
import Movies from './components/Movies';
import MovieDetails from './components/MovieDetails'
import './custom.css'
const App = () => {

    return (
        <Layout>
            <Route exact path='/' component={Home} />
            <Route path='/Movies' component={Movies} />
            <Route path='/MovieDetails' component={MovieDetails} />
        </Layout>
    );
}

export default App;