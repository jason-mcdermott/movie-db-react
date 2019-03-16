import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { MovieList } from './components/MovieList';
import { DirectorList } from './components/DirectorList';

export default class App extends Component {
  displayName = App.name

  render() {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/movies' component={MovieList} />
        <Route path='/directors' component={DirectorList} />
      </Layout>
    );
  }
}
