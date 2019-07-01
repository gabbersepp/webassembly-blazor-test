function getCurrentDate() {
    return new Date().toString();
}

function showAlert(arg) {
    alert("This is a message: " + arg);
}

function resolvePromiseAfterMS(ms) {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            resolve("resolved");
        }, ms);
    });
}