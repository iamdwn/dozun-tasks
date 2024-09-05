import { useEffect, useState } from "react";
import { getDztasksAPI } from "../../api/dztasks";
import "./index.css";

const Dztasks = () => {
    const [tasks, setTasks] = useState([]);

    useEffect(() => {
        fetchData();
    }, []);

    const fetchData = async () => {
        try {
            const response = await getDztasksAPI();
            setTasks(response);
        } catch (error) {
            console.error("Error fetching tasks:", error);
        }
    };

    return (
        <main id="todolist">
            <h1>
                Dozun Tasks
                <span>Just do it !!!!!</span>
            </h1>

            {/* Render the tasks dynamically */}
            <ul>
                {tasks.map((task) => (
                    <li key={task.id} className={task.done ? "done" : ""}>
                        <span className="label">{task.name}</span>
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
                ))}
            </ul>

            <form>
                <label htmlFor="name">Add a new task in here</label>
                <input type="text" name="name" id="name" />
                <input type="text" name="id" id="id" />
                <button type="button">Add new</button>
            </form>
        </main>
    );
};

export default Dztasks;
