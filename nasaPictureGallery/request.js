var req = new XMLHttpRequest();
let requestUrl = new URL('https://api.nasa.gov/mars-photos/api/v1/rovers/perseverance/photos');
let sol = 1;
let page = 1;
let api_key = 'Hlzd3hr2M2lUChERx2uoJV0E5JJrfUd3vqpMQBJd';

requestUrl.searchParams.append('sol', sol.toString());
requestUrl.searchParams.append('page', page.toString());
requestUrl.searchParams.append('api_key', api_key);


function collectURLString(sol, page, api_key) {

    sol = (parseInt(localStorage.getItem('sol'))) + 1;

    requestUrl.searchParams.set('sol', sol);
    requestUrl.searchParams.set('page', page);
    requestUrl.searchParams.set('api_key', api_key);
    console.log(requestUrl.toString());
    localStorage.setItem('sol', sol);
    return requestUrl.toString();
}


window.addEventListener("load", (event) => {
    localStorage.setItem('sol', String(0));
    req.open('GET', requestUrl.toString());
    req.send();
    req.onload = function () {
        if (req.status >= 200 && req.status < 300 && JSON.parse(req.response).length === 0){
            getNextDayPictures();
        }
        else if(req.status >= 200 && req.status < 300) {
            const obj = JSON.parse(req.response);
            for (var i = 0; i < obj.photos.length; i++) {
                var photo = obj.photos[i].img_src.toString();
                $(".gallery").append("<img class='marsPhoto'><img/>")
                $(".marsPhoto:last").attr('src', photo);
            }
        }
    };
});


function getNextDayPictures() {
    req.open('GET', collectURLString(sol, page, api_key));
    req.send();
}


window.onload = function () {
    $('.previousDay').click(function () {
        getNextDayPictures();
    })
};


window.addEventListener("click", ev => {
        $('.marsPhoto:hover').click(
            function () {
                var src = $('.marsPhoto:hover').attr('src');
                $('body').append("<div class='viewerContainer'><div class='locker'> </div><img src=" + src + "> </img></div>");
            }
        )
    }
);

window.addEventListener("click", ev => {
$('.locker').click(
    function () {
        $('.viewerContainer').remove();
    }
)
});















