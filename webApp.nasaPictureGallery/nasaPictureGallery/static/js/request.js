let api_key = 'Hlzd3hr2M2lUChERx2uoJV0E5JJrfUd3vqpMQBJd';
let firstDayOfPicture = "2005-01-04";

var request = new XMLHttpRequest();

import {addANewPageOfPictures, loadFirsPageOfPicturesOnDate} from './loadImageFunctions.js';
import {checkUserToken} from "./sqlQueries.js";


export function setValueIsLastPage(value) {
    localStorage.setItem("doesThePageIsLast", value);
}

export function getValueIsLastPage() {
    let val = localStorage.getItem("doesThePageIsLast");
    return (val === 'true');
}

export function setPageNumber(value) {
    localStorage.setItem("pageNumber", value);
}

export function getPageNumber() {
    let val = localStorage.getItem("pageNumber");
    return parseInt(val);
}


window.addEventListener("load", (event) => {
    setPageNumber("1");
    setValueIsLastPage("false");
    let dateString = new Date();
    let dateOfPictures = dateString.toISOString().split("T")[0];

    document.querySelector(".date").setAttribute("max", dateOfPictures);
    document.querySelector(".date").valueAsDate = dateString;
    loadFirsPageOfPicturesOnDate(dateOfPictures, api_key);
    addDatePickerListener();
    addListenerOfTheEndOfThePage();
    photoClickInitEvent();
    checkUserToken("token68");

   // $('.background').append("<div class='authorisationForm'></div><div class='locker'></div>");
   // $(".authorisationForm").load("authorisationForm.html");


});


function addListenerOfTheEndOfThePage() {
    var lastElement = document.querySelector(".observer");

    var options = {
        root: document.querySelector('#scrollArea'),
        rootMargin: '0px',
        threshold: 0.25
    };

    var callback = function (entries, observer) {
        let dateOfPictures = document.querySelector(".date").value;
        addANewPageOfPictures(dateOfPictures, api_key);
    };

    var observer = new IntersectionObserver(callback, options);
    observer.observe(lastElement);
}


function addDatePickerListener() {
    document.querySelector(".date").addEventListener("change", ev => {
            setPageNumber("1");
            setValueIsLastPage("false");
            $(".gallery").empty();
            var choosenDate = document.querySelector(".date").value;
            if (choosenDate === '') {
                console.log("Подсветить инпут. Некорректная дата");
            } else if (new Date(choosenDate).getTime() <= new Date(firstDayOfPicture).getTime() || new Date(choosenDate).getTime() > new Date().getTime()) {
                console.log("Подсветить инпут. Некорректная дата");
            } else {
                loadFirsPageOfPicturesOnDate(choosenDate, api_key);
            }
        }
    );
}


function photoClickInitEvent() {
    document.querySelector(".gallery").addEventListener("click", ev => {
            if (!ev.target.classList.contains("marsPhoto")) {
                return;
            }
            var image = ev.target.src;
            console.log(ev.target.className);
            $('.background').append("<div class='viewerContainer'></div><div class='locker'> </div>");
            $(".viewerContainer").load("photoViewer.html");


        }
    );
}


window.addEventListener("click", ev => {
    $('.locker').click(
        function () {
            $('.viewerContainer').remove();
            $('.locker').remove();
        }
    )
});
