import React, { Component } from 'react';
import { BackButton } from './BackButton';

export class DirectorList extends Component {
  displayName = DirectorList.name

  constructor(props) {
    super(props);
    this.state = {
        directors: [],
        loading: true
    };

    this.displayDirector = this.displayDirector.bind(this);
    
    fetch('api/director/list')
      .then(response => response.json())
      .then(data => {
          this.setState({ directors: data, loading: false });
      });
    }

    displayDirector(e, id) {
        e.preventDefault();
        this.props.history.push(`/director/${id}`);
    } 
    
    static renderDirectorTable(self) {
        return (
          <table className='table'>
            <thead>
              <tr>
                <th>Director</th>
                <th>Years Active</th>
              </tr>
            </thead>
            <tbody>
            {self.state.directors.map(director =>
                <tr key={director.id}>
                    <td><a href="" onClick={(e) => self.displayDirector(e, director.id)}>{director.name}</a></td>
                    <td>{director.yearsActive}</td>
                </tr>
              )}
            </tbody>
          </table>
        );
    }

    render() {
        let self = this;
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : DirectorList.renderDirectorTable(self);

        return (
          <div>
            <h1>Directors</h1>
            <p>Welcome to the Movie Database</p>
                {contents}
            <BackButton history={this.props.history} />
          </div>
        );
     }
}