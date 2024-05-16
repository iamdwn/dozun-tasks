const Dztasks = () => {
    const data = [];
    alert(process.env.REACT_APP_URL_API);

    return (
        <main id="todolist">
        <h1>
            Dozun Tasks
            <span>Just do it !!!!!</span>
        </h1>

        <li class="done">
            <span class="label">123</span>
            <div class="actions">
                <button class="btn-picto" type="button">
                    <i class="fas fa-edit"></i>
                </button>
                <button class="btn-picto" type="button" aria-label="Delete" title="Delete">
                    <i class="fas fa-trash"></i>
                </button>
            </div>
        </li>
        <li>
            <span class="label">123</span>
            <div class="actions">
                <button class="btn-picto" type="button">
                    <i class="fas fa-user-edit"></i>
                </button>
                <button class="btn-picto" type="button" aria-label="Delete" title="Delete">
                    <i class="fas fa-trash"></i>
                </button>
            </div>
        </li>
        <p> </p>

        <form>
            <label htmlFor="name">Add a new task in here</label>
            <input type="text" name="name" id="name"/>
            <input type="text" name="id" id="name"/>
            <button type="button">Add new</button>
        </form>
    </main>
    )
}

export default Dztasks;