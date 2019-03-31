import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { MovieList } from './components/MovieList';
import { Movie } from './components/Movie';
import { DirectorList } from './components/DirectorList';
import { Director } from './components/Director';

export default class App extends Component {
  displayName = App.name

  render() {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/movies' component={MovieList} />
        <Route path='/movie/:id' component={Movie} />  
        <Route path='/directors' component={DirectorList} />
        <Route path='/director/:id' component={Director} />
      </Layout>
    );
  }
}