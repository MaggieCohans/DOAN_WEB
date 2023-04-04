function _class(name) {
    return document.getElementsByClassName(name);
}
let tabsPanel = _class("tab-header")[0].getElementsByTagName("button");
for (let i = 0; i < tabsPanel.length; i++) {
    tabsPanel[i].addEventListener("click", function () {
        _class("tab-header")[0].getElementsByClassName("active")[0].classList.remove("active");
        tabsPanel[i].classList.add("active");
        _class("tab-content")[0].getElementsByClassName("active")[0].classList.remove("active");
        _class("tab-content")[0].getElementsByTagName("div")[i].classList.add("active");

    })
}