import React, { Component } from 'react';
import { BackButton } from './BackButton';

export class Movie extends Component {
    displayName = Movie.name

  constructor(props) {
    super(props);
      this.state = {
          movie: {},
          loading: true
      };

    this.displayDirector = this.displayDirector.bind(this);
    
    let id = this.props.match.params["id"];  

    fetch(`api/movie/${id}`)
      .then(response => response.json())
      .then(data => {
          this.setState({ movie: data, loading: false });
      });
    }

    displayDirector(e, id) {
        e.preventDefault();
        this.props.history.push(`/director/${id}`);
    } 
    
    static renderMovieTable(movie, self) {
        return (
          <table className='table'>
            <thead>
              <tr>
                <th>Title</th>
                <th>Director</th>
                <th>Release Date</th>
              </tr>
            </thead>
            <tbody>
                <tr key={movie.id}>
                    <td>{movie.title}</td>
                    <td><a href="" onClick={(e) => self.displayDirector(e, movie.director.id)}>{movie.director.name}</a></td>
                    <td>{movie.releaseDate}</td>
                </tr>
            </tbody>
          </table>
        );
      }

    render() {
        var self = this;
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Movie.renderMovieTable(this.state.movie, self);
      
        return (
          <div>
            <h1>Movie</h1>
            <p>Welcome to the Movie Database</p>
                {contents}
            <BackButton history={this.props.history} />
          </div>
        );
    }
}
