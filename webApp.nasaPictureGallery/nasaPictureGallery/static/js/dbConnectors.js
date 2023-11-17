const Pool = require('pg').Pool;
const pool = new Pool({
    user: 'v.glinskiy',
    host: 'localhost',
    database: 'gallery',
    password: '',
    port: 5432,
});


const isUserTokenValid = (token) => {
    return new Promise((resolve, reject) => {
        pool.query('select count(session_token) from public.user_access where session_token = $1', [token], (error, results) => {
            if (error) {
                reject(error);
            }
            resolve(results);
        })
    });
};



const getUsers = (request, response) => {
    pool.query('select table_name from information_schema.tables', (error, results) => {
        if (error) {
            throw error
        }
        response.status(200).json(results.rows)
    })
};



module.exports = {
    getUsers,
    isUserTokenValid
};