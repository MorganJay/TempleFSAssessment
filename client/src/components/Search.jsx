import React from "react";
import styled from "styled-components";

const Search = ({ searchValue, onSubmit, onSearch }) => {
  const handleSearch = e => {
    if (e.charCode === 13) onSubmit();
  };

  return (
    <SearchContainer>
      <input
        type="text"
        placeholder="Search for a word"
        title="Search for any word on the planet"
        value={searchValue}
        onChange={onSearch}
        onKeyPress={handleSearch}
      />
      <button onClick={onSubmit}>Search</button>
    </SearchContainer>
  );
};

export default Search;

const SearchContainer = styled.div`
  display: flex;
  justify-content: space-around;
  align-items: center;
  gap: 1rem;
  flex-wrap: wrap;
  width: 80%;
  padding-top: 50px;
  
  input {
    /* border: 1px solid #eee; */
    border: 0.4px solid #282c34;
    height: 30px;
    padding: 2px 10px;
    font-size: 15px;
    border-radius: 5px;
    width: 100%;

    &::placeholder {
      font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", "Roboto",
        "Oxygen", "Ubuntu", "Cantarell", "Fira Sans", "Droid Sans",
        "Helvetica Neue", sans-serif;
    }
  }

  button {
    display: inline-block;
    padding: 0.75rem 1.25rem;
    border-radius: 10rem;
    color: white;
    background-color: #282c34;
    text-transform: uppercase;
    font-size: 1rem;
    /* letter-spacing: 0.15rem; */
    transition: all 0.3s;
    font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", "Roboto",
      "Oxygen", "Ubuntu", "Cantarell", "Fira Sans", "Droid Sans",
      "Helvetica Neue", sans-serif;
    cursor: pointer;
    position: relative;
    overflow: hidden;
    z-index: 1;
    border: none;
    &:after {
      content: "";
      position: absolute;
      bottom: 0;
      left: 0;
      width: 100%;
      height: 100%;
      background-color: #282c34;
      border-radius: 10rem;
      z-index: -2;
    }
    &:before {
      content: "";
      position: absolute;
      bottom: 0;
      left: 0;
      width: 0%;
      height: 100%;
      background-color: #61626452;
      transition: all 0.3s;
      border-radius: 10rem;
      z-index: -1;
    }
    &:hover {
      color: #fff;
      &:before {
        width: 100%;
      }
    }
  }
`;
