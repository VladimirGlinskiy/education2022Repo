var req = new XMLHttpRequest();

import {getRoversList, collectURLString} from "./sendRequestFunctions.js";
import {getPageNumber, setPageNumber, getValueIsLastPage, setValueIsLastPage} from "./request.js";

function loadFirsPageOfPicturesOnDate(dateString, api_key) {

    let roversList = getRoversList(dateString);
    console.log("rovers list: " + JSON.stringify(roversList));

    for (let name of roversList) {
        console.log("name: " + name);
        req.open('GET', collectURLString(dateString, getPageNumber(), api_key, name), false);
        req.send();
        req.onload = function () {
            if (req.status >= 200 && req.status < 300) {

                if (JSON.parse(req.response).photos.length === 0 && roversList.length === 1) {
                    console.log("last rovers photo are empty");
                    $(".gallery").append("<img class='lastImage'><img/><div class='farewellWord'>В этот день не было опубликовано фотографий." +
                        "  </div><div class='farewellWord'>Попробуйте выбрать другую дату и продолжайте просмотр</div>");
                    $(".lastImage").attr('src', './media/noImageToday.jpg');
                    setValueIsLastPage("true");

                } else if (JSON.parse(req.response).photos.length === 0 && roversList.length !== 1) {
                    let index = roversList.indexOf(name);
                    if (index !== -1) {
                        roversList.splice(index, 1);
                        console.log("Updated rovers list: " + roversList);
                    }
                } else {
                    const obj = JSON.parse(req.response);
                    for (var i = 0; i < obj.photos.length; i++) {

                        let photoObject = obj.photos[i];
                        var photo = photoObject.img_src.toString();
                        var photoMadeDate = photoObject.earth_date.toString();
                        var roverName = photoObject.rover.name.toString();
                        var photoID = photoObject.id.toString();

                        $(".gallery").append("<div class='marsPhotoCard'><img class='marsPhoto'>" +
                            "<div class = 'labelCover'><p class = 'roverNameLabel'>марсоход: </p>" +
                            "<div class = 'photoRoverName'></div><br>" +
                            "<div class='likes'>Понравилось: 12</div>"+
                            "<div class='comments'>Комментарии: 2</div>"+
                            " </div>" +
                            "<div class = 'photoInfoID'></div>" +
                            "<div class = 'photoInfoDate'></div>"+
                            "</div>"
                        );
                        $(".marsPhoto:last").attr('src', photo);
                        $(".marsPhotoCard:last .photoRoverName").html(roverName);
                        $(".marsPhotoCard:last .photoInfoID").addClass(photoID);
                        $(".marsPhotoCard:last .photoInfoDate").addClass(photoMadeDate);
                    }
                }
            }
        }
    }
}

export {loadFirsPageOfPicturesOnDate}

function addANewPageOfPictures(dateOfPictures, api_key) {

    if (getValueIsLastPage() === true) {
        return;
    }

    setPageNumber( getPageNumber() + 1 );

    let roversList = getRoversList(dateOfPictures);
    for (let name of roversList) {

        req.open('GET', collectURLString(dateOfPictures, getPageNumber(), api_key, name), false);
        req.send();
        req.onload = function () {
            if (req.status >= 200 && req.status < 300) {
                const obj = JSON.parse(req.response);

                if (obj.photos.length === 0 && roversList.length === 1) {
                    $(".gallery").append("<img class='lastImage'/><div class='farewellWord'>Вы посмотрели все фотографии опубликованные за этот день.</div>" +
                        "<div class='farewellWord'> Попробуйте выбрать другую дату и продолжайте просмотр </div>");
                    $(".lastImage").attr('src', './media/finish.jpeg');
                    setValueIsLastPage("true");
                } else if (obj.photos.length === 0 && roversList.length !== 1) {
                    let index = roversList.indexOf(name);
                    if (index !== -1) {
                        roversList.splice(index, 1);
                        console.log("Add new page. Updated rovers list: " + roversList);
                    }
                } else {
                    for (var i = 0; i < obj.photos.length; i++) {
                        let photoObject = obj.photos[i];
                        var photo = photoObject.img_src.toString();
                        var photoMadeDate = photoObject.earth_date.toString();
                        var roverName = photoObject.rover.name.toString();
                        var photoID = photoObject.id.toString();

                        $(".gallery").append("<div class='marsPhotoCard'><img class='marsPhoto'>" +
                            "<div class = 'labelCover'><p class = 'roverNameLabel'>марсоход: </p>" +
                            "<p class = 'photoRoverName'></p>" +
                            "<div class = 'photoInfoID'></div>" +
                            "<div class = 'photoInfoDate'></div>"+
                            "</div>"
                        );
                        $(".marsPhoto:last").attr('src', photo);
                        $(".marsPhotoCard:last .photoRoverName").html(roverName);
                        $(".marsPhotoCard:last .photoInfoID").addClass(photoID);
                        $(".marsPhotoCard:last .photoInfoDate").addClass(photoMadeDate);
                    }
                }
            }
        }
    }
}

export {addANewPageOfPictures}