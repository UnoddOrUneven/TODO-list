
const button = document.querySelector('#confetti-button');
const canvas = document.querySelector('#confetti');

const jsConfetti = new JSConfetti()
button.addEventListener('click', () => {
    console.log("Clicked!");
    jsConfetti.addConfetti();
});

function shootConfettiAndSubmit(checkbox) {
    if (checkbox.checked) {
        jsConfetti.addConfetti();
        setTimeout(() => {
            checkbox.form.submit(checkbox);
        }, 2000);
    }
    else {
        checkbox.form.submit(checkbox);
        console.log("HELLLO WORLDD");
    }
    
    
    
    

}