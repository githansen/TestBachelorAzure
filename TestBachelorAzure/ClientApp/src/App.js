import logo from './logo.svg';
import './App.css';
import $ from 'jquery'

const r = () => {
    console.log("Funker")
  
    const p = {
        fornavn: $("#fornavn").val(),
        etternavn: $("#etternavn").val()
    }
    $.ajax({
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        'type': 'POST',
        'url': "https://testbacheloraz.azurewebsites.net//api/Values/lagre",
        'data': JSON.stringify(p),
        'dataType': 'json',
        
    })
   
}
function App() {
  return (
      <div className="App">
          <label for="fornavn">Fornavn</label>
          <input type="text" id="fornavn"></input> <br/>

          <label for="etternavn">Etternavn</label>
          <input type="text" id="etternavn"></input>
          <button onClick={r}>Test</button>
    </div>
  );
}

export default App;
