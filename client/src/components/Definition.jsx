import React from "react";
import styled from "styled-components";

import SearchFigure from "../assets/undraw_searching_p5ux.png";

const Definition = ({ definitions, word }) => {
  return (
    <DefinitionContainer>
      {definitions ? (
        definitions.map(({ type, meaning, example, emoji }, i) => (
          <DefinitionComponent key={i}>
            <div>Type: {type}</div>
            <div>Meaning: {meaning}</div>
            <div>Example: {example || `Hi ${word}`}</div>
            <div>{emoji ? `Emoji: ${emoji}` : "No emoji found"}</div>
          </DefinitionComponent>
        ))
      ) : (
        <NoSearch>
          <img src={SearchFigure} alt="Search Figure" />
          <h3>Try searching for a word</h3>
        </NoSearch>
      )}
    </DefinitionContainer>
  );
};

export default Definition;

const DefinitionContainer = styled.div`
  min-height: 100%;
  max-height: 200px;
  overflow-y: auto;
  p {
    text-align: center;
  }
`;

const NoSearch = styled.div`
  text-align: center;
  margin-top: 3rem;
  img {
    width: 50%;
  }
`;

const DefinitionComponent = styled.div`
  margin-top: 5px;
  padding: 0 0 10px;
  font-size: 0.9rem;
  display: flex;
  flex-direction: column;
  justify-content: space-between;
  gap: 0.5rem;
  border: 0px solid #ccc;
  border-top-width: 1px;
  border-bottom-width: 1px;
`;
