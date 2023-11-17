
var req = new XMLHttpRequest();

export function checkUserToken (token) {

    let url = new URL("http://localhost:3000/getToken");
    url.searchParams.append("token", token);

    req.open("GET", url);
    req.send();
    req.onload = function () {
        console.log("Результат вызова GET ", req.response );
        const obj = JSON.parse(req.response);

    };
}

