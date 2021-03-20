import React, { Component } from 'react';

export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
    super(props);
    this.state = { drivers: [], loading: true };
  }

  componentDidMount() {
      this.populateDriversData();
  }

  static renderDriversTable(drivers) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Name</th>
            <th>Email</th>
            <th>Phone</th>
          </tr>
        </thead>
        <tbody>
          {drivers.map(driver =>
            <tr key={driver.Id}>
              <td>{driver.User.Name}</td>
              <td>{driver.User.Email}</td>
              <td>{driver.User.Phone}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : FetchData.renderDriversTable(this.state.drivers);

    return (
      <div>
        <h1 id="tabelLabel" >Weather forecast</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }

  async populateDriversData() {
    const response = await fetch('http://localhost:5000/api/drivers');
      const data = await response.json();
      console.log(response);
    this.setState({ drivers: data, loading: false });
  }
}
