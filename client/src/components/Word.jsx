import React from "react";
import styled from "styled-components";

import Definition from "./Definition";

const dummyImage =
  "https://media.owlbot.info/dictionary/images/sandals-4124759_1280.jpg.400x400_q85_box-158,0,1011,853_crop_detail.jpg";

const Word = ({ data }) => {
  return (
    <Container>
      {data?.definitions[0]?.image_url ? (
        <ImageContainer>
          <img src={dummyImage} placeholder="Image dey" alt="wedgies" />
        </ImageContainer>
      ) : data ? (
        <div>
          <p>Word: {data?.word}</p>
          <span>Pronunciation: {data && `/${data.pronunciation}/`}</span>
        </div>
      ) : null}
      <Definition definitions={data?.definitions} word={data?.word} />
    </Container>
  );
};

export default Word;

const Container = styled.div`
  height: 68%;
  width: 50%;
  text-align: left;
  font-size: 0.9rem;
`;

const ImageContainer = styled.div`
  text-align: center;
  margin-bottom: 0.4rem;
  img {
    border-radius: 50%;
    width: 15%;
    margin: 5px auto;
  }
`;
