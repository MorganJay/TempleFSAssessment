import { useState } from "react";
import { toast, ToastContainer } from "react-toastify";

import Search from "./components/Search";
import Word from "./components/Word";

import dictionaryService from "./services/dictionaryService";
import http from "./services/httpService";

import "react-toastify/dist/ReactToastify.css";
import "./App.css";

function App() {
  const [search, setSearch] = useState("");
  const [loading, setLoading] = useState(false);
  const [data, setData] = useState(null);

  const handleChange = e => {
    const { value } = e.target;
    setSearch(value);
  };

  const handleSubmit = async () => {
    try {
      if (!search) return toast.error("Please enter a word");

      setLoading(true);
      const { data } = await dictionaryService.searchWord(search);
      console.log(data);
      setData(data);
      setLoading(false);
      setSearch("");
    } catch (error) {
      if (http.expectedError(error, 400)) {
        setLoading(false);
        console.log(error);
        const data = error.response.data.errors;
        toast.error(data);
      }

      if (http.expectedError(error, 404)) {
        setLoading(false);
        setSearch("");
      }

      setLoading(false);
      toast.error("An unexpected error occurred.");
    }
  };

  return (
    <div className="App">
      <ToastContainer />
      <header className="App-header">
        <Search
          searchValue={search}
          onSubmit={handleSubmit}
          onSearch={handleChange}
        />
        {loading ? (
          <div className="loading">Searching...</div>
        ) : (
          <Word data={data} />
        )}
      </header>
      <footer>
        Powered by{" "}
        <a href="https://www.owbot.info" target="_blank" rel="noreferrer">
          Owlbot
        </a>
      </footer>
    </div>
  );
}

export default App;
