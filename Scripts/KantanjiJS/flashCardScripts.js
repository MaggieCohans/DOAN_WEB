const next = document.querySelector(".slider-next");
const flasscard = document.querySelector(".flass-card");
const flasscardItems = document.querySelectorAll(".flass-card-item");
let postionX = 0;
const widthFlCard = flasscard.offsetWidth;

const flasscardLength = [...flasscardItems].length;
const codition = widthFlCard * flasscardLength;

// play song
const song = document.querySelector("#song");
let playing = true;
const sounds = document.querySelectorAll(".sound");
[...sounds].forEach((item) =>
    item.addEventListener("click", function (e) {
        if (playing) {
            song.play();
            playing = false;
        } else {
            song.pause();
            playing = true;
        }
    })
);

next.addEventListener("click", function (e) {
    postionX = postionX + widthFlCard;
    if (postionX >= codition) {
        postionX = 0;
    }
    flasscard.style = ` transform: translateX(${-postionX}px);`;
});

//Button đúng sai
const correct = document.querySelector(".correct");
const incorrect = document.querySelector(".incorrect");
let numberCorrect = 0;
let numberIncorrect = 0;
correct.addEventListener("click", function (e) {

    postionX = postionX + widthFlCard;
    if (postionX >= codition) {
        postionX = condition;
    } else {
        numberCorrect++;
        correct.textContent = `Số câu đúng: ${numberCorrect}`;
    }
    flasscard.style = ` transform: translateX(${-postionX}px);`;
})
incorrect.addEventListener("click", function (e) {

    postionX = postionX + widthFlCard;
    if (postionX >= codition) {
        postionX = condition;
    } else {
        numberIncorrect++;
        incorrect.textContent = `Số câu sai: ${numberIncorrect}`;
    }
    flasscard.style = ` transform: translateX(${-postionX}px);`;
})
