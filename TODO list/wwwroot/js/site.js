
const button = document.querySelector('#confetti-button');
const canvas = document.querySelector('#confetti');

const jsConfetti = new JSConfetti()
button.addEventListener('click', () => {
    console.log("Clicked!");

});

function shootConfettiAndSubmit(checkbox) {
    if (checkbox.checked) {
        jsConfetti.addConfetti({
            emojis: ['✅'],
        })
        
    }
    fetch(checkbox.form.action, {
        method: 'POST',
        body: formData
    })
        .then(() => {
            console.log("Setting updated!");
        })
        .catch((error) => {
            console.error("Error submitting:", error);
        });
    
    
    
    

}