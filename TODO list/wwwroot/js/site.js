

const canvas = document.querySelector('#confetti');

const jsConfetti = new JSConfetti()


function shootConfettiAndSubmit(checkbox) {
    const formData = new FormData(checkbox.form); 
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