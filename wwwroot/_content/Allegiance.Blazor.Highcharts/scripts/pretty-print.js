window.prettyPrint = function () {
    setTimeout(function () {
        PR.prettyPrint();
        var cols = document.getElementsByClassName('opacity-load');
        for (i = 0; i < cols.length; i++) {
            cols[i].classList.remove('opacity-load');
        }
    }, 700);
}
