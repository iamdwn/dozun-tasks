import { useEffect, useRef, useState } from "react";
import { addTasksAPI, delDztasksAPI, editTasksAPI, getDztasksAPI } from "../../api/dztasks";
import "./index.css";

const Dztasks = () => {
    const [tasks, setTasks] = useState([]);
    const [editId, setEditId] = useState(null);
    const [preId, setPreId] = useState(null);
    const [taskName, setTaskName] = useState('');
    const taskRef = useRef([]);

    useEffect(() => {
        fetchData();
    }, []);

    const fetchData = async () => {
        try {
            const response = await getDztasksAPI();
            setTasks(response || []);
        } catch (error) {
            console.error("Error fetching tasks:", error);
            setTasks([]);
        }
    };

    const delTask = async (id) => {
        if (window.confirm("Are you sure to delete it?")) {
            await delDztasksAPI(id);
            // window.location.reload;
            setTasks(tasks.filter(task => task.id !== id)); 
        }
    };

    const addOrEditTasks = async (event) => {
        event.preventDefault();
        const name = taskName.trim();
        const id = editId;
        if (!name) {
            alert("Task name cannot be empty");
            return;
        }

        if (editId) {
            await editTasksAPI({
                name, id
            })
            editTask(id);
            setPreId(id);
            setTasks(tasks.map(task => task.id === editId ? { ...task, name } : task));
            taskRef.current[id].className = "fas fa-edit";
            setEditId(null);
        } else {
            const newTask = await addTasksAPI({ name });
            setTasks([...tasks, newTask]);
        }

        fetchData();
        setTaskName('');    
    };

    const editTask = (id) => {
        if (id === preId) {
            if (taskRef?.current[id].className === "fas fa-user-edit") {
                taskRef.current[id].className = "fas fa-edit";
                setTaskName("");
            } else if (taskRef?.current[id].className === "fas fa-edit") {
                taskRef.current[id].className = "fas fa-user-edit";
                const taskToEdit = tasks.find(task => task.id === id);
                setTaskName(taskToEdit.name);
            }

            window.location.reload();
        } else {
            if (taskRef?.current[id].className === "fas fa-user-edit") {
                taskRef.current[id].className = "fas fa-edit";
                setTaskName("");
            } else if (taskRef?.current[id].className === "fas fa-edit") {
                taskRef.current[id].className = "fas fa-user-edit";
                const taskToEdit = tasks.find(task => task.id === id);
                setTaskName(taskToEdit.name);
            }

            if (preId != null) {
                if (taskRef?.current[preId].className === "fas fa-user-edit") {
                    taskRef.current[preId].className = "fas fa-edit";
                    // setTaskName("");
                }
            }

            setEditId(id);
            setPreId(id);
        }

        
    };

    const onIsCompleteTask = async (task) => {
        var updatedTask = {
            ...task,
            isComplete: task.isComplete ? false : true,
            done: !task.done
        };
        
        await editTasksAPI(updatedTask);
        setTasks(tasks.map(t => t.id === task.id ? updatedTask : t));
    };

    return (
        <main id="todolist">
            <h1>
                Dozun Tasks
                <span>Just do it !!!!!</span>
            </h1>

            <ul>
                {Array.isArray(tasks) && tasks.length > 0 ? (
                    tasks.map((task) => (
                        task && (
                            <li key={task.id} className={task.isComplete ? "done" : ""} onDoubleClick={() => onIsCompleteTask(task)}>
                                <span className="label">{task.name}</span>
                                <div className="actions">
                                    <button className="btn-picto" 
                                        type="button"
                                        onClick={() => editTask(task.id)}
                                    >
                                        <i 
                                        className="fas fa-edit" 
                                        ref = {el => taskRef.current[task.id]= el}
                                        />
                                    </button>
                                    <button
                                        className="btn-picto"
                                        type="button"
                                        aria-label="Delete"
                                        title="Delete"
                                        onClick={() => delTask(task.id)}
                                    >
                                        <i className="fas fa-trash" />
                                    </button>
                                </div>
                            </li>
                        )
                    ))
                ) : (
                    <li>No tasks available</li>
                )}
            </ul>

            <form onSubmit={addOrEditTasks}>
                <label htmlFor="name">Add a new task here</label>
                <input 
                    type="text" 
                    name="name" 
                    id="name" 
                    value={taskName} 
                    onChange={(e) => setTaskName(e.target.value)} 
                />
                <button type="submit">{editId ? "Edit Task" : "Add Task"}</button>
            </form>
        </main>
    );
};

export default Dztasks;
