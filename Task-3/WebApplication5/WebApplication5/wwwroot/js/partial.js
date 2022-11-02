let loadBtn = document.getElementById("loadMore")
let skip = 4;
let productList = document.getElementById("ProductList")
let productCount = document.getElementById("ProductCount").value;


loadBtn.addEventListener("click", function () {
    fetch('/product/partial?skip=' + skip)
        .then(response => response.text())
        .then(data => {
            productList.innerHTML += data
            skip += 4;
            if (skip >= productCount)
                loadBtn.remove();
        })

})
