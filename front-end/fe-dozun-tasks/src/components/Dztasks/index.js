import { useEffect } from "react";
import { getDztasksAPI } from "../../api/dztasks";
import "./index.css";

const Dztasks = () => {
    const data = [];
    // alert(process.env.REACT_APP_URL_API);

    useEffect(() => {
        fetchData();
    }, [])

    const fetchData = async () => {
        const data = getDztasksAPI;
        console.log(data);
    }

    return (
<main id="todolist">
  <h1>
    Dozun Tasks
    <span>Just do it !!!!!</span>
  </h1>
  <li className="done">
    <span className="label">123</span>
    <div className="actions">
      <button className="btn-picto" type="button">
        <i className="fas fa-edit" />
      </button>
      <button
        className="btn-picto"
        type="button"
        aria-label="Delete"
        title="Delete"
      >
        <i className="fas fa-trash" />
      </button>
    </div>
  </li>
  <li>
    <span className="label">123</span>
    <div className="actions">
      <button className="btn-picto" type="button">
        <i className="fas fa-user-edit" />
      </button>
      <button
        className="btn-picto"
        type="button"
        aria-label="Delete"
        title="Delete"
      >
        <i className="fas fa-trash" />
      </button>
    </div>
  </li>
  <p> </p>
  <form>
    <label htmlfor="name">Add a new task in here</label>
    <input type="text" name="name" id="name" />
    <input type="text" name="id" id="name" />
    <button type="button">Add new</button>
  </form>
</main>
    )
}

export default Dztasks;